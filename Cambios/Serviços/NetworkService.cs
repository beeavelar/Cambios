namespace Cambios.Serviços
{
    using Modelos;
    using System.Net;

    public class NetworkService
    {
        public Response CheckConnection()//Método para verificar se tem conxão com a internet
        {
            var client = new WebClient();

            try
            {
                using (client.OpenRead("http://clients3.goolge.com/begerate_204"))
                {
                    return new Response
                    {
                        IsSuccess = true
                    };
                }
            }
            catch
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = "Verifique/Configure a sua ligação à Internt."
                };
            }
        }
    }
}
