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
                Saldo = 100.50,
                Email = "yyyyyy",
                Activo = true
            };
            Abonado abonado2 = new Abonado
            {
                Id = 2,
                Nombre = "Maria Lopez",
                Identidad = "0801199012346",
                Saldo = 75.25,
                Telefono = "8888-8888",
                Email = "zzzzzz",
                Activo = false
            };
            Abonado abonado3 = new Abonado
            {
                Id = 3,
                Nombre = "Carlos Gomez",
                Identidad = "0801199012347",
                Telefono = "7777-7777",
                Saldo= 50.75,
                Email = "wwwwww",
                Activo = false
            };
            Abonado abonado4 = new Abonado
            {
                Id = 4,
                Nombre = "Ana Martinez",
                Identidad = "0801199012348",
                Telefono = "6666-6666",
                Saldo = 25.00,
                Email = "vvvvvv",
                Activo = true
            };
            Abonado abonado5 = new Abonado
            {
                Id = 5,
                Nombre = "Luis Rodriguez",
                Identidad = "0801199012349",
                Telefono = "5555-5555",
                Saldo = 10.00,
                Email = "uuuuuu",
                Activo = true
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
