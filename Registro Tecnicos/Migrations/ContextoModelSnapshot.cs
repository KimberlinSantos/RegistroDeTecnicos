using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RegistroTecnicos.DAL;

#nullable disable

namespace RegistroTecnicos.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.4");


            
           

            modelBuilder.Entity("RegistroTecnicos.Models.Incentivos", b =>
            {
                
               
               

                b.Navigation("Tecnicos");
            });


            

            modelBuilder.Entity("RegistroTecnicos.Models.TiposTecnicos", b =>
            {
                b.Navigation("Tecnicos");
            });
#pragma warning restore 612, 618
        }
    }
}
