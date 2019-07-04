using McAfee.Sample.Layered.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McAfee.Sample.Layered.Service
{
    /*
     * Request/Response messaging pattern for client to interact with service layer.
     */
    public class ProductListRequest
    {
        public CustomerType CustomerType { get; set; }
    }
}
