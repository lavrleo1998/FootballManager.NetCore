using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface IPersonService
    {
        Person GetPerson(long id);
    }
}
