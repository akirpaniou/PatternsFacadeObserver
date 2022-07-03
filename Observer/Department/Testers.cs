using Observer.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Observer.Department
{
    public interface IAsset
    {
        void AllocateAsset();
    }
    public class Testers : IAsset, IResignationObserver
    {
        public Testers(IResignation resignation)
        {
            resignation.AddObserver(this);
        }
        public void AllocateAsset()
        {

        }

        public void Notify(string employeeId)
        {
            //если сотрудник уходит в отставку уведомление
            //будет приходить сюда
            UpdXmlFile xmlFile = new UpdXmlFile();
            xmlFile.UpdateNotificationDetail("Testers", employeeId);
        }
    }
}
