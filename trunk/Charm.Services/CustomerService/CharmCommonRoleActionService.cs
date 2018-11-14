using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Charm.Entity;
using Charm.Entity.Role;

namespace Charm.Services
{
    public partial interface ICharmCommonRoleActionService
    {
        /// <summary>
        /// 角色授权保存
        /// </summary>
        /// <param name="roleId"></param>
        /// <param name="actionIds"></param>
        /// <returns></returns>
        bool Authorization(Guid roleId, Guid[] actionIds);
    }

    public partial class CharmCommonRoleActionService : ICharmCommonRoleActionService
    {
        /// <summary>
        /// 角色授权保存
        /// </summary>
        /// <param name="roleId"></param>
        /// <param name="actionIds"></param>
        /// <returns></returns>
        public bool Authorization(Guid roleId, Guid[] actionIds)
        {
            using (var context = new DbContext())
            {
                context.CharmCommonRoleActionContext.Delete(" AND RoleId = @RoleId", new Dictionary<string, object>() { { "@RoleId", roleId } });

                if (actionIds != null)
                {
                    foreach (var actionId in actionIds)
                    {
                        context.CharmCommonRoleActionContext.Add(
                            new CharmCommonRoleAction()
                            {
                                RoleActionId = Guid.NewGuid(),
                                ActionId = actionId,
                                RoleId = roleId,
                                CreateDate = DateTime.Now,
                                ModifyDate = null
                            });
                    }
                }

                return context.SaveChanges() > 0;
            }
        }
    }
}
