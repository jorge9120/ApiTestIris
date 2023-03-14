using ApiTestIris.Models;

namespace ApiTestIris.Services
{
    public interface ISeleccionService
    {
        IEnumerable<Seleccion> GetAll();
        Seleccion GetById(int id);
        void Create(Seleccion model);
        void Update(Seleccion model);
        void Delete(int id);
        IEnumerable<Seleccion> GetByState(string state);
    }
}
