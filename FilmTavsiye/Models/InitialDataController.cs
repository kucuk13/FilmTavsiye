using FilmTavsiye.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmTavsiye.Models
{
    public static class InitialDataController
    {
        public static List<Member> GetMemberData()
        {
            return new List<Member>
            {
                new Member
                {
                    Id = 1,
                    Name = "admin",
                    Password = "123456",
                    CreatedMemberId = 1
                },
                new Member
                {
                    Id = 2,
                    Name = "editor",
                    Password = "123456",
                    CreatedMemberId = 1
                }
            };
        }

        public static List<Constant> GetConstantData()
        {
            return new List<Constant>
            {
                new Constant
                {
                    Id = 1,
                    Name = "System Roles",
                    CreatedMemberId = 1
                },
                new Constant
                {
                    Id = 2,
                    Name = "Status",
                    CreatedMemberId = 1
                },
                new Constant
                {
                    Id = 3,
                    Name = "Task",
                    CreatedMemberId = 1
                },
                new Constant
                {
                    Id = 4,
                    Name = "Movie Type",
                    CreatedMemberId = 1
                },
                new Constant
                {
                    Id = 5,
                    Name = "Country",
                    CreatedMemberId = 1
                },
                new Constant
                {
                    Id = 6,
                    Name = "Media Type",
                    CreatedMemberId = 1
                },
                new Constant
                {
                    Id = 7,
                    Name = "Photo Type",
                    CreatedMemberId = 1
                },
                new Constant
                {
                    Id = 8,
                    Name = "Video Type",
                    CreatedMemberId = 1
                },
                new Constant
                {
                    Id = 9,
                    Name = "Pegi",
                    CreatedMemberId = 1
                },
            };
        }

        public static List<ConstantValue> GetConstantValuesData()
        {
            return new List<ConstantValue>
            {
                new ConstantValue
                {
                    Id = (int)Enums.Status.Active,
                    Name = "Active",
                    ConstantId = 2,
                    CreatedMemberId = 1
                },
                new ConstantValue
                {
                    Id = (int)Enums.Status.Passive,
                    Name = "Passive",
                    ConstantId = 2,
                    CreatedMemberId = 1
                },
                new ConstantValue
                {
                    Id = (int)Enums.Status.Deleted,
                    Name = "Deleted",
                    ConstantId = 2,
                    CreatedMemberId = 1
                },
                new ConstantValue
                {
                    Id = (int)Enums.SystemRoles.Admin,
                    Name = "Admin",
                    ConstantId = 1,
                    CreatedMemberId = 1
                },
                new ConstantValue
                {
                    Id = (int)Enums.SystemRoles.Editor,
                    Name = "Editor",
                    ConstantId = 1,
                    CreatedMemberId = 1
                }
            };
        }

        public static List<MemberRole> GetMemberRoleData()
        {
            return new List<MemberRole>
            {
                new MemberRole
                {
                    Id = 1,
                    MemberId = 1,
                    RoleId = (int)Enums.SystemRoles.Admin,
                    CreatedMemberId = 1
                },
                new MemberRole
                {
                    Id = 2,
                    MemberId = 2,
                    RoleId = (int)Enums.SystemRoles.Editor,
                    CreatedMemberId = 1
                }
            };
        }

    }
}
