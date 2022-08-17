using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStop.BL
{
    public class BodegaBL
    {
        Contexto _contexto;
        public List<Bodega> ListadeBodega { get; set; }

        public BodegaBL()
        {
            _contexto = new Contexto();
            ListadeBodega = new List<Bodega>();
        }
        public List<Bodega> ObtenerBodega()
        {
            ListadeBodega = _contexto.Bodega.ToList();
            return ListadeBodega;
        }

        public void GuardarBodega(Bodega Bodega)
        {
            if (Bodega.Id == 0)
            {
                _contexto.Bodega.Add(Bodega);
            }
            else
            {
                var BodegaExistente = _contexto.Bodega.Find(Bodega.Id);
                BodegaExistente.Descripcion = Bodega.Descripcion;
            }

            _contexto.SaveChanges();
        }

        public Bodega ObtenerBodega(int id)
        {
            var Bodega = _contexto.Bodega.Find(id);

            return Bodega;

        }

        public void EliminarBodega(int id)
        {
            var Bodega = _contexto.Bodega.Find(id);

            _contexto.Bodega.Remove(Bodega);
            _contexto.SaveChanges();
        }

    }
}
