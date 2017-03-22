using MuscleFellow.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MuscleFellow.Data.Interfaces
{
    public interface IProductRepository
    {
        /// <summary>
        /// 异步获取全部产品
        /// </summary>
        /// <returns></returns>
        Task<List<Product>> GetAllAsync();
        /// <summary>
        /// 异步向数据源添加一个商品
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        Task<Guid> AddAsync(Product product);
        /// <summary>
        /// 删除产品
        /// </summary>
        /// <param name="productID"></param>
        /// <returns></returns>
        Task DeleteAsync(Guid productID);
        /// <summary>
        /// 根据id获取产品
        /// </summary>
        /// <param name="productID"></param>
        /// <returns></returns>
        Task<Product> GetAsync(Guid productID);
        /// <summary>
        /// 根据条件和分页信息获取产品
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageCount"></param>
        /// <returns></returns>
        Task<IEnumerable<Product>> GetProductAsync(string filter, int pageSize, int pageCount);
        /// <summary>
        /// 按照修改时间倒序排列，获取产品
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        Task<IEnumerable<Product>> GetPopularProductsAsync(int count);
        /// <summary>
        /// 更新产品信息
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        Task<Guid> UpdateAsync(Product product);
    }
}
