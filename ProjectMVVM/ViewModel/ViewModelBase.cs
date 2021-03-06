﻿using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Reflection;

namespace ProjectMVVM
{
	public class ViewModelBase : ViewModelBase<object>
	{
	}

	public class ViewModelBase<T> : INotifyPropertyChanged
		where T : class, new()
	{
		private T _entity;

		T Entity { 
			get
			{
				return _entity;
			}
			set
			{
				_entity = value;
				RaisedPropertyChanged(() => Entity);
			}
		}

		public ViewModelBase()
		{
			Entity = new T();
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected void RaisedPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}

		protected void RaisedPropertyChanged<T>(Expression<Func<T>> expression)
		{
			var member = expression.Body as MemberExpression;
			var propertyInfo = member.Member as PropertyInfo;

			if (propertyInfo != null)
			{
				if (PropertyChanged != null)
				{
					PropertyChanged(this, new PropertyChangedEventArgs(propertyInfo.Name));
				}
			}
		}


	}
}
