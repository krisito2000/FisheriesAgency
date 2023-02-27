using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace FisheriesAgency.Model
{
    public class FisheriesContext : FisheriesAgencyDB
    {
        public FisheriesContext(FisheriesAgencyDBOptions<FisheriesContext> options): base(options)
        {
        }
    }
}
