using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HLgrocery.Model.Models;
using HLgrocery.Web.Models;

namespace HLgrocery.Web.Infrastructure.extensions
{
    public static class EntityExtensions
    {
        public static void UpdatePostCategory(this PostCategory postCategory, PostCategoryViewModel postCategoryVm)
        {
            postCategory.ID = postCategoryVm.ID;
            postCategory.Name = postCategoryVm.Name;
            postCategory.Description = postCategoryVm.Description;
            postCategory.Alias = postCategoryVm.Alias;
            postCategory.ParentID = postCategoryVm.ParentID;
            postCategory.DisplayOrder = postCategoryVm.DisplayOrder;
            postCategory.Image = postCategoryVm.Image;
            postCategory.HomeFlag = postCategoryVm.HomeFlag;

            postCategory.CreatedDate = postCategoryVm.CreatedDate;
            postCategory.CreatedBy = postCategoryVm.CreatedBy;
            postCategory.UpdatedDate = postCategoryVm.UpdatedDate;
            postCategory.UpdatedBy = postCategoryVm.UpdatedBy;
            postCategory.MetaKeyword = postCategoryVm.MetaKeyword;
            postCategory.MetaDescription = postCategoryVm.MetaDescription;
            postCategory.Status = postCategoryVm.Status;

        }
        public static void UpdateProductCategory(this ProductCategory productCategory, ProductCategoryViewModel productCategoryVm)
        {
            productCategory.ID = productCategoryVm.ID;
            productCategory.Name = productCategoryVm.Name;
            productCategory.Description = productCategoryVm.Description;
            productCategory.Alias = productCategoryVm.Alias;
            productCategory.ParentID = productCategoryVm.ParentID;
            productCategory.DisplayOrder = productCategoryVm.DisplayOrder;
            productCategory.Image = productCategoryVm.Image;
            productCategory.HomeFlag = productCategoryVm.HomeFlag;

            productCategory.CreatedDate = productCategoryVm.CreatedDate;
            productCategory.CreatedBy = productCategoryVm.CreatedBy;
            productCategory.UpdatedDate = productCategoryVm.UpdatedDate;
            productCategory.UpdatedBy = productCategoryVm.UpdatedBy;
            productCategory.MetaKeyword = productCategoryVm.MetaKeyword;
            productCategory.MetaDescription = productCategoryVm.MetaDescription;
            productCategory.Status = productCategoryVm.Status;

        }
        public static void UpdatePost(this Post post, PostViewModel postVm)
        {
            post.ID = postVm.ID;
            post.Name = postVm.Name;
            post.Description = postVm.Description;
            post.Alias = postVm.Alias;
            post.CategoryID = postVm.CategoryID;
            post.Content = postVm.Content;
            post.Image = postVm.Image;
            post.HomeFlag = postVm.HomeFlag;
            post.ViewCount = postVm.ViewCount;

            post.CreatedDate = postVm.CreatedDate;
            post.CreatedBy = postVm.CreatedBy;
            post.UpdatedDate = postVm.UpdatedDate;
            post.UpdatedBy = postVm.UpdatedBy;
            post.MetaKeyword = postVm.MetaKeyword;
            post.MetaDescription = postVm.MetaDescription;
            post.Status = postVm.Status;
        }
    }
}