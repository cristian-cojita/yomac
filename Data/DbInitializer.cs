using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using yomac.Data;

namespace yomac.Models
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            

            if(!context.ConvectorRecords.Any()){
                var convectorRecord = new Convector{
                    CRetur = 13.39M,
                    CTur = 13.69M,
                    CRefulare = 13.6M,
                    CAspiratie = 13.70M,
                    DeviceId = "123",
                    ReadAt = new DateTime(2016,12,31,23,59,00)
                };
                context.ConvectorRecords.Add(convectorRecord);
                context.SaveChanges();
            }
        }
    }
}
