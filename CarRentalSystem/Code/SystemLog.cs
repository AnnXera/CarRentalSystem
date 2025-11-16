using System;
using System.Collections.Generic;
using CarRentalSystem.Database;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem.Code
{
    public class SystemLog
    {
        public long LogID { get; set; }
        public DateTime LogDate { get; set; }
        public string Action { get; set; }
        public string Description { get; set; }
        public string EmployeeName { get; set; }
    }

    public class SystemLogFactory : IModalFactory<SystemLog>
    {
        private readonly SystemLogRepository _repo;

        public SystemLogFactory()
        {
            _repo = new SystemLogRepository();
        }

        public List<SystemLog> ViewAll()
        {
            return _repo.GetAllLogs();
        }

        public long Add(SystemLog log)
        {
            throw new NotImplementedException();
        }

        public void Edit(SystemLog log)
        {
            throw new NotImplementedException();
        }
    }
}
