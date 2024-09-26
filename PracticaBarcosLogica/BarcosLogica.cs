using PracticaBarcosEntidades;

namespace PracticaBarcosLogica
{
    public class BarcosLogica:IBarcoLogica
    {


        private  List<Barco> _items = new List<Barco>();


       

            public void AgregarBarco(Barco barco)
        {
            barco.IdBarco = _items.Count == 0 ? 1 : _items.Max(x => x.IdBarco) + 1;
            _items.Add(barco);
        }

        
        public List<Barco> Listado()
        {
            return _items
                .OrderBy(x => x.IdBarco)
                .ToList();
        }

      
    }

    public interface IBarcoLogica
    {
        void AgregarBarco(Barco barco);
        List<Barco> Listado();
    }





}







