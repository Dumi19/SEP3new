using System.Threading.Tasks;
using Models;
using WebApi.Data.DataAccess;

namespace Data.Impl
{
    //put it to program.cs its just a little draw
    public class AdminService
    {
        private async Task InsertAdministrator()
        {
            Administrator dumi = new Administrator
            {
                adminUsername = "Dumi",
                adminPassword = "1234",
            };

            Administrator pawel = new Administrator
            {
                adminUsername = "Pawel",
                adminPassword = "1234",
            };

            using (SEP3WebApiContext dbContext = new SEP3WebApiContext())
            {
                await dbContext.Administrators.AddAsync(dumi);
                await dbContext.Administrators.AddAsync(pawel);
                await dbContext.SaveChangesAsync();
            }

        }
    }
}