using System.Net;
using System.Threading;
using System.Web.Http;
using WebApplicationTestProjectTwo.Models;

namespace WebApplicationTestProjectTwo.Controllers
{
    [AllowAnonymous]
    [RoutePrefix("api/login")]
    public class LoginController : ApiController
    {
        [HttpPost]
        [Route("authenticate")]
        public IHttpActionResult Authenticate(LoginRequest login)
        {
            if (login == null)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            bool isCredentialValid = (login.Username == "admin" && login.Password == "123456" && login.Rol.ToLower() == "ciudadano");
            if (isCredentialValid)
            {
                var token = TokenGenerator.GenerateTokenJwt(login.Username);
                return Ok(token);
            }
            else
            {
                return Unauthorized();
            }
        }

    }
}
