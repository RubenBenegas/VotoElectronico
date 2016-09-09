using System;
using System.Collections.Generic;
using System.Linq;
using Entidades;



namespace Reglas
{
    public abstract class BaseMapper<T> where T: IEntidad
    {
        public virtual void Grabar(T entidad)
        {
            var lista = new List<T> { entidad };
            Grabar(lista);
        }

        public virtual void Grabar(IEnumerable<T> entidades)
        {
            var listaEntidades = entidades.ToList();

            var itemsAGrabar = new List<T>();
            itemsAGrabar.AddRange(listaEntidades);

            var itemsExistentes = ObtenerTodas().ToList();
            foreach (var itemExist in itemsExistentes)
            {
                var existe = false;
                foreach (var item in listaEntidades)
                {
                    if (item.Id.Equals(itemExist.Id))
                    {
                        existe = true;
                    }

                }
                if (!existe)
                {
                    itemsAGrabar.Add(itemExist);
                }
            }

            var persistor = new EntityPersistor<T>();
            persistor.Grabar(itemsAGrabar);
        }


        public virtual IEnumerable<T> ObtenerTodas()
        {
            var persistor = new EntityPersistor<T>();
            return persistor.Recuperar();
        }

        public virtual T ObtenerUna(Guid id)
        {
            var todas = ObtenerTodas();

            return todas.
                FirstOrDefault(p => p.Id.Equals(id));
        }

        public virtual void EliminarUna(Guid id)
        {
            var itemsAGrabar = new List<T>();

            var itemsExistentes = ObtenerTodas().ToList();
            // Agregamos todos lo de la lista menos el item a eliminar
            foreach (var item in itemsExistentes)
            {
                if (!item.Id.Equals(id))
                {
                    itemsAGrabar.Add(item);
                }
            }

            // Y grabamos la lista que tiene todos menos el que queremos eliminar
            var persistor = new EntityPersistor<T>();
            persistor.Grabar(itemsAGrabar);
        }

        public virtual void EliminarTodas()
        {
            var persistor = new EntityPersistor<T>();
            persistor.Eliminar();
        }

    }
}
