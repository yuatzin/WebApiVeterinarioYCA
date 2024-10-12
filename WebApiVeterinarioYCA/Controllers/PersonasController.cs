using Microsoft.AspNetCore.Http;
using EntidadPersonas1;
using Microsoft.AspNetCore.Mvc;
using WebApiVeterinarioYCA.Models;

namespace WebApiVeterinarioYCA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonasController : ControllerBase
    {
        [HttpGet]
        public List<cPersonas> listaPersonas()
        {
            List<cPersonas> Lista = new List<cPersonas>();

        
        
        try
        { 
                using (VeterinariaContext db=new VeterinariaContext())
            {
            Lista=(from persona in db.Personas
                   where persona.Bhabilitado==1 
                   select new cPersonas
                   { 
                       IdPersona=persona.Iidpersona,
                       nombreCompleto= persona.Nombre + ""+
                       persona.Appaterno + " "+ persona .Apmaterno,
                       correo = persona.Correo,
                       fechaNacimiento= persona.Fechanacimiento.Value.ToString("dd/MM/yyyy")

                   }

                        ).ToList();
            }
                return Lista;
    }
    catch (Exception ex)
    {
    return Lista;
        }
         }
        [HttpGet]
        public List<cPersonas> listaPersonas()
        {
            List<cPersonas> Lista = new List<cPersonas>();



            try
            {
                using (VeterinariaContext db = new VeterinariaContext())
                {
                    Lista = (from persona in db.Personas
                             where persona.Bhabilitado == 1
                             select new cPersonas
                             {
                                 IdPersona = persona.Iidpersona,
                                 nombreCompleto = persona.Nombre + "" +
                                 persona.Appaterno + " " + persona.Apmaterno,
                                 correo = persona.Correo,
                                 fechaNacimiento = persona.Fechanacimiento.Value.ToString("dd/MM/yyyy")

                             }

                                ).ToList();
                }
                return Lista;
            }
            catch (Exception ex)
            {
                return Lista;
            }
        }
    }

}
