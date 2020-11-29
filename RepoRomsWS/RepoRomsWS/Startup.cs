using Microsoft.Owin;
using Owin;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using RepoRomsWS.Models;

[assembly: OwinStartupAttribute(typeof(RepoRomsWS.Startup))]
namespace RepoRomsWS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            CrearRolesUsuario();
        }

        public void CrearRolesUsuario()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            var ManejadorRol = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var ManejadorUsuario = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            if (!ManejadorRol.RoleExists("Admin"))
            {
                /*sino existe, se crea el rol y se asigna un nuevo usuario con ese rol*/
                var rol = new IdentityRole();
                rol.Name = "Admin";
                ManejadorRol.Create(rol);
                /*creamos un primer usuario para ese rol*/
                var user = new ApplicationUser();
                user.UserName = "admin@gmail.com";
                user.Email = "admin@gmail.com";
                string PWD = "12345678";
                var chkUser = ManejadorUsuario.Create(user, PWD);
                /*si se creo con exito*/
                if (chkUser.Succeeded)
                {
                    ManejadorUsuario.AddToRole(user.Id, "Admin");
                }
            }

            if (!ManejadorRol.RoleExists("Digitador"))
            {
                var rol = new IdentityRole();
                rol.Name = "Digitador";
                ManejadorRol.Create(rol);
                var user = new ApplicationUser();
                user.UserName = "digitador@gmail.com";
                user.Email = "digitador@gmail.com";
                string PWD = "12345678";
                var chkUser = ManejadorUsuario.Create(user, PWD);
            }
        }
    }
}
