﻿using System;
namespace DeNSo.Meta
{
  public interface ISession
  {
    int Count(string collection);
    int Count(string collection, System.Linq.Expressions.Expression<Func<DeNSo.Meta.BSon.BSonDoc, bool>> filter);
    int Count<T>();
    int Count<T>(System.Linq.Expressions.Expression<Func<T, bool>> filter) where T : class, new();
    string DataBase { get; set; }
    long Delete<T>(string collection, T entity);
    long Delete<T>(T entity) where T : class;
    long Execute<T>(T command) where T : class;
    System.Collections.Generic.IEnumerable<DeNSo.Meta.BSon.BSonDoc> Get(string collection, System.Linq.Expressions.Expression<Func<DeNSo.Meta.BSon.BSonDoc, bool>> filter = null);
    System.Collections.Generic.IEnumerable<T> Get<T>(System.Linq.Expressions.Expression<Func<T, bool>> filter = null) where T : class, new();
    System.Collections.Generic.IEnumerable<T> Get<T>(string collection, System.Linq.Expressions.Expression<Func<T, bool>> filter = null) where T : class, new();
    long Set<T>(string collection, T entity) where T : class;
    long Set<T>(T entity) where T : class;
  }
}
