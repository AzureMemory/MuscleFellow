using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Collections.Generic;
using System.Text;

namespace MuscleFellow.Models
{
    public class IdentityUser<TKey> where TKey : IEquatable<TKey>
    {
        public IdentityUser() { }

        public IdentityUser(string userName) { }

        /// <summary>
        /// 用于记录故障来实现锁定
        /// </summary>
        public virtual int AccessFailedCount { get; set; }

        /// <summary>
        /// 声明用户的导航属性
        /// </summary>
        public virtual ICollection<IdentityUserClaim<TKey>> Claims { get; }

        /// <summary>
        /// 当用户持久化到商城时，这个值就发生变化
        /// </summary>
        public virtual string ConcurrencyStamp { get; set; }

        /// <summary>
        /// email
        /// </summary>
        public virtual string Email { get; set; }

        /// <summary>
        /// 邮件是否确认
        /// </summary>
        public virtual bool EmailConfirmed { get; set; }
        public virtual TKey Id { get; set; }

        /// <summary>
        /// 用户是否被锁定
        /// </summary>
        public virtual bool LockoutEnabled { get; set; }

        /// <summary>
        /// UTC锁定结束时间
        /// </summary>
        public virtual DateTimeOffset? LockoutEnd { get; set; }

        /// <summary>
        /// 用户登录的导航属性
        /// </summary>
        public virtual ICollection<IdentityUserLogin<TKey>> Logins { get; }
        public virtual string NormallizedEmail { get; set; }
        public virtual string NormlizedUserNmae { get; set; }

        /// <summary>
        /// 用户密码的加盐/哈希值
        /// </summary>
        public virtual string PasswordHash { get; set; }
        
        /// <summary>
        /// 手机号
        /// </summary>
        public virtual string PhoneNumber { get; set; }

        /// <summary>
        /// 手机号码是否已经确认，默认值为false
        /// </summary>
        public virtual bool PhoneNumberConfirmed { get; set; }

        /// <summary>
        /// 用户角色的导航属性
        /// </summary>
        public virtual ICollection<IdentityUserRole<TKey>> Roles { get; }

        /// <summary>
        /// 随机值 当用户凭证发生变化时（密码改变，退出登录）
        /// </summary>
        public virtual string SecurityStamp { get; set; }

        /// <summary>
        /// 是否为用户启用双元素
        /// </summary>
        public virtual bool TwoFactorEnabled { get; set; }

        public virtual string UserName { get; set; }
    }
}
