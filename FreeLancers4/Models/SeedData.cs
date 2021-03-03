using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using FreeLancers4.Data;//name of my Data file 

namespace FreeLancers4.Models
{
    public class SeedData
    {

        public static void Initialize(IServiceProvider service)
        {
            using (var context = new FreeLancers4Context(
                service.GetRequiredService<DbContextOptions<FreeLancers4Context>>()))
            {
                //check for data in table
                if(context.Work.Any() && context.History.Any())
                {
                    return;
                    //DB has been seeded
                }

                /*
                  if(!context.Work.Any())
                {
                    context.Work.AddRange(
                       new Work
                       {
                           ProjectTitle = "Ted Birthday Website",
                           Description = "I need a photo album esquie website to celebrate my uncles birthday next year, id like it to be acceabile for everywhere and make it so that i can let people leave comments under the pictures ",
                           PostDate = DateTime.Parse("2019-3-24"),
                           Price = 45M,//the m makes it a double
                            DueDate = DateTime.Parse("2020-4-22"),
                           Skills = "HTML, CSS, PHP, SQL",
                           Techneeded = "I dont know",
                           ContactEmail = "test1@email.com"
                       },
                       new Work
                       {
                           ProjectTitle = "We'll change the rest chill",
                           Description = "I need a photo album esquie website to celebrate my uncles birthday next year, id like it to be acceabile for everywhere and make it so that i can let people leave comments under the pictures ",
                           PostDate = DateTime.Parse("2019-3-24"),
                           Price = 45M,//the m makes it a double
                            DueDate = DateTime.Parse("2020-4-22"),
                           Skills = "HTML, CSS, PHP, SQL",
                           Techneeded = "I dont know",
                           ContactEmail = "@"
                       },
                       new Work
                       {
                           ProjectTitle = "I guess you will ",
                           Description = "I need a photo album esquie website to celebrate my uncles birthday next year, id like it to be acceabile for everywhere and make it so that i can let people leave comments under the pictures ",
                           PostDate = DateTime.Parse("2019-3-24"),
                           Price = 45M,//the m makes it a double
                            DueDate = DateTime.Parse("2020-4-22"),
                           Skills = "HTML, CSS, PHP, SQL",
                           Techneeded = "I dont know",
                           ContactEmail = "@"
                       }
                   );//add some table data
                }

                if(!context.History.Any())
                {
                    context.History.AddRange(
                        new History
                        {
                            
                            Project = "I need a pineapple rendered in 3d 4k resolution",
                            UserName = "Mr Crabs",
                            Proffesion = "Animated/Sculptor",
                            Rating = 5,
                            CompleteDate = DateTime.Parse("2019-12-21")
                            
                        },
                        new History
                        {
                            
                            Project = "I need a web app that allows user to contact freelance developers for i.t projects",
                            UserName = "Mr Mwaang",
                            Proffesion = "Web App Developer",
                            Rating = 5,
                            CompleteDate = DateTime.Parse("2021-2-5")

                        }
                   );
                }
                */
               
                context.SaveChanges();
      
            }
        }

    }
}
