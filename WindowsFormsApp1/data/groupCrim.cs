using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criminals
{
    public class groupCrim
{
    public string LastName { get; }
    public string FirstName { get; }
    public string Nickname { get; }
    public bool IsLeader { get; }
    public bool IsArchived { get; }
    public string GroupName { get; }

    public groupCrim(string lastName, string firstName, string nickname, string groupName, bool isLeader = false, bool isArchived = false)
    {
        LastName = lastName;
        FirstName = firstName;
        Nickname = nickname;
        IsLeader = isLeader;
        IsArchived = isArchived;
        GroupName = groupName;
    }

}

}
