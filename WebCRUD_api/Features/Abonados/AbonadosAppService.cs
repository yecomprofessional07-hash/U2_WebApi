using System.Runtime.CompilerServices;
using WebCRUD_api.enitities;

namespace WebCRUD_api.Features.Abonados
{
    public class AbonadosAppService
    {
        private List<Abonado> abonados = new List<Abonado>();
        private AbonadosDomainService domain;
        public AbonadosAppService()
        {
            Abonado abonado1 = new Abonado
            {
                Id = 1,
                Nombre = "Juan Perez",
                Identidad = "0801199012345",
                Telefono = "9999-9999",
                Email = "yyyyyy"
            };
            Abonado abonado2 = new Abonado
            {
                Id = 2,
                Nombre = "Maria Lopez",
                Identidad = "0801199012346",
                Telefono = "8888-8888",
                Email = "zzzzzz"
            };
            Abonado abonado3 = new Abonado
            {
                Id = 3,
                Nombre = "Carlos Gomez",
                Identidad = "0801199012347",
                Telefono = "7777-7777",
                Email = "wwwwww"
            };
            domain = new AbonadosDomainService();
        }

        public void GuardarAbonado(Abonado abonado)
        {
            if (!domain.GuardarAbonado(abonado))
            {
                return;
            }
            abonados.Add(abonado);
        }

        public List<Abonado> ObtenerAbonados()
        {
            return abonados;
        }
        public Abonado ObtenerAbonadoPorId(int id)
        {
            return abonados.FirstOrDefault(a => a.Id == id);
        }

        public void ActualizarAbonado(Abonado abonado)
        {
            Abonado? abonadoExistente = abonados.Where(a => a.Id == abonado.Id).FirstOrDefault();
            if (abonadoExistente == null)
            {
               return;
            }
            abonadoExistente.Nombre = abonado.Nombre;
            abonadoExistente.Identidad = abonado.Identidad;
            abonadoExistente.Telefono = abonado.Telefono;
            abonadoExistente.Email = abonado.Email;
            abonadoExistente.Saldo = abonado.Saldo;
            abonadoExistente.Fechapago = abonado.Fechapago;
            abonadoExistente.Activo = abonado.Activo;
        }
         public void EliminarAbonado(int id)
        {
            abonados.RemoveAll(a => a.Id == id);

        }
    }
}
