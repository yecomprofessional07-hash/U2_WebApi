using WebCRUD_api.enitities;

namespace WebCRUD_api.Features.Abonados
{
    public class AbonadosDomainService
    {
        public AbonadosDomainService() { }

        public bool GuardarAbonado(Abonado abonado)
        {
            if (string.IsNullOrEmpty(abonado.Nombre)) {  return false; }
                
            if (string.IsNullOrEmpty(abonado.Identidad) || abonado.Identidad.Length != 13) { return false; }
            
            if (string.IsNullOrEmpty(abonado.Telefono)|| abonado.Identidad.Length <8) { return false; }
            
            if (string.IsNullOrEmpty(abonado.Email)) { return false; }
            
            if (abonado.Saldo < 0) { return false; }

            return true;

        }
    }
}
