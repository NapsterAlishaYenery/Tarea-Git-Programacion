using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Service
{
    public sealed class MainRepository
    {
        public static MainRepository Instance { get; } = new MainRepository();

        public int? EntityTypesIndex = null;

        public int? GroupIndex = null;

        public int? EntityIndex = null;
    }
}
