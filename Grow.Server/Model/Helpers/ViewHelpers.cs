﻿using Grow.Data;
using Grow.Data.Entities;
using Grow.Data.Helpers.Attributes;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading.Tasks;

namespace Grow.Server.Model.Helpers
{
    public static class ViewHelpers
    {
        public static string GetControllerFor(Type type)
        {
            return type.Name.ToLower() + "s";
        }

        /// <summary>
        /// Data cleaner method that removes all navigation properties to BaseEntity entities. 
        /// 
        /// The goal is to avoid updating data of navigation properties.
        /// </summary>
        /// <typeparam name="T">Type of the entity that will be cleaned</typeparam>
        /// <param name="entity">The entity that should be cleaned</param>
        public static void RemoveAllNavigationProperties<T>(T entity) where T : BaseEntity
        {
            var partialNavProperties =
                from navProp in typeof(T).GetProperties()
                where navProp.GetMethod.IsVirtual
                    && typeof(BaseEntity).IsAssignableFrom(navProp.PropertyType)
                    && navProp.GetValue(entity) is BaseEntity
                select navProp;

            // Clear nav property
            foreach (var propertyToBeCleared in partialNavProperties)
            {
                propertyToBeCleared.SetValue(entity, null);
            }
        }

        /// <summary>
        /// Data cleaner method that removes all navigation properties to BaseEntity entities where only partial data is contained. 
        /// 
        /// The goal is to avoid data loss due to partial data.
        /// 
        /// Partial data is detected when the property is not null, no id is set in the object, but the id property is set.
        /// </summary>
        /// <typeparam name="T">Type of the entity that will be cleaned</typeparam>
        /// <param name="entity">The entity that should be cleaned</param>
        public static void RemovePartialNavigationProperties<T>(T entity) where T : BaseEntity
        {
            PropertyInfo idProp;
            BaseEntity navEntity;

            // We want all navigation properties...
            var partialNavProperties =
                from navProp in typeof(T).GetProperties()
                where navProp.GetMethod.IsVirtual
                    // ...where navigation property has some data, but no id...
                    && typeof(BaseEntity).IsAssignableFrom(navProp.PropertyType)
                    && (navEntity = navProp.GetValue(entity) as BaseEntity) != null
                    && navEntity.Id == 0
                    // ...but id property has a value 
                    && (idProp = typeof(T).GetProperty(navProp.Name + "Id")) != null
                    && (idProp.GetValue(entity) as int?) > 0
                select navProp;

            // Clear nav property
            foreach (var propertyToBeCleared in partialNavProperties)
            {
                propertyToBeCleared.SetValue(entity, null);
            }
        }

        public static IEnumerable<SelectListItem> SelectListFromEnum<T>()
        {
            if (!typeof(Enum).IsAssignableFrom(typeof(T)))
                throw new ArgumentException("Given Type must be an enum");

            var list = new List<SelectListItem>();

            foreach (int value in Enum.GetValues(typeof(T)))
                list.Add(new SelectListItem(Enum.GetName(typeof(T), value), Enum.GetName(typeof(T), value).ToLower()));
            return list;
        }

        public static IEnumerable<SelectListItem> SelectListFromEntities<T>(GrowDbContext context) where T : BaseTimestampedEntity
        {
            var files = context
                .Set<T>()
                .OrderBy(e => e.Name);

            return SelectListFromEntityList(files);
        }

        public static IEnumerable<SelectListItem> SelectListFromEntities<T>(GrowDbContext context, int currentContestId) where T : BaseContestSubEntity
        {
            var files = context
                .Set<T>()
                .Where(e => e.ContestId == currentContestId)
                .OrderBy(e => e.Name);

            return SelectListFromEntityList(files);
        }
        
        public static IEnumerable<SelectListItem> SelectListFromFiles<TSource>(GrowDbContext context, Expression<Func<TSource, File>> propertyLambda) where TSource : BaseEntity
        {
            var fileCategory = GetFileCategoryForProperty(propertyLambda);

            var files = context
                .Set<File>()
                .Where(e => (e.Category ?? "misc").Equals(fileCategory.ToString(), StringComparison.CurrentCultureIgnoreCase))
                .OrderBy(e => e.Name);

            return SelectListFromEntityList(files);
        }

        public static string GetFileCategoryForProperty<TSource>(Expression<Func<TSource,File>> propertyLambda) where TSource : BaseEntity
        {
            if (!(propertyLambda.Body is MemberExpression member))
                throw new ArgumentException("Invalid referenced member", nameof(propertyLambda));

            if (!(member.Member is PropertyInfo propInfo))
                throw new ArgumentException("Referenced member is not a property", nameof(propertyLambda));

            var fileCategory = FileCategory.Misc;
            var attr = propInfo.GetCustomAttribute<FileCategoryAttribute>();
            if (attr != null)
                fileCategory = attr.Category;

            return fileCategory.ToString();
        }

        private static IEnumerable<SelectListItem> SelectListFromEntityList(IEnumerable<BaseNamedEntity> entities)
        {
            var list = new List<SelectListItem>
            {
                new SelectListItem
                {
                    Text = "",
                    Value = null
                }
            };

            foreach (var entity in entities)
            {
                var name = entity.Name ?? entity.GetType().Name + " " + entity.Id;
                var item = new SelectListItem(name, entity.Id.ToString());
                list.Add(item);
            }

            return list;
        }
    }
}
