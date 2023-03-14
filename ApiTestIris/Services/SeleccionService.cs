using ApiTestIris.Models;

namespace ApiTestIris.Services
{
    public class SeleccionService : ISeleccionService
    {
        ApiTestIrisDBContext _context;
        public SeleccionService(ApiTestIrisDBContext context)
        {
            _context = context;
        }

        public void Create(Seleccion model)
        {
            //var item = _mapper.Map<Seleccion>(model);
            _context.seleccion.Add(model);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var user = _context.seleccion.Find(id);
            _context.seleccion.Remove(user);
            _context.SaveChanges();
        }

        public IEnumerable<Seleccion> GetAll()
        {
            return _context.seleccion;
        }

        public Seleccion GetById(int id)
        {
            var seleccion = _context.seleccion.Find(id);
            return seleccion;
        }

        public void Update(Seleccion model)
        {
            var seleccion = _context.seleccion.Find(model.Id);
            seleccion.State = model.State;
            _context.seleccion.Update(seleccion);
            _context.SaveChanges();

        }

        public IEnumerable<Seleccion> GetByState(string state)
        {
            var listState = _context.seleccion;
            var existe = listState.Where(n => n.State == state);
            return existe;
        }
    }
}
