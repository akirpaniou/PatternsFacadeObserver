using Observer.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Observer.Department
{
    public interface ILibrary
    {
        void LookBook();
    }
    public class Library : ILibrary, IResignationObserver
    {
        public Library(IResignation resignation)
        {
            resignation.AddObserver(this);
        }

        public void LookBook()
        {
            throw new NotImplementedException();
        }

        public void Notify(string employeeId)
        {
            UpdXmlFile xmlFile = new UpdXmlFile();
            xmlFile.UpdateNotificationDetail("Library", employeeId);
        }
    }
}
