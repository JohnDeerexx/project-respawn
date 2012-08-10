using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
namespace ns1
{
	internal static class Class119
	{
		[CompilerGenerated]
		private sealed class Class121<T, U> where T : class where U : IComparable
		{
			public Func<T, U> func_0;
			public Class38<T, U> method_0(T gparam_0)
			{
				return new Class38<T, U>(gparam_0, this.func_0(gparam_0));
			}
			public Class38<T, U> method_1(T gparam_0)
			{
				return new Class38<T, U>(gparam_0, this.func_0(gparam_0));
			}
		}
		[CompilerGenerated]
		private sealed class Class120<T, U> where T : class where U : IComparable
		{
			public Func<T, U> func_0;
			public Class38<T, U> method_0(T gparam_0)
			{
				return new Class38<T, U>(gparam_0, this.func_0(gparam_0));
			}
			public Class38<T, U> method_1(T gparam_0)
			{
				return new Class38<T, U>(gparam_0, this.func_0(gparam_0));
			}
		}
		public static T smethod_0<T, U>(this IEnumerable<T> ienumerable_0, Func<T, U> func_0) where T : class where U : IComparable
		{
			Class119.Class121<T, U> @class = new Class119.Class121<T, U>();
			@class.func_0 = func_0;
			T result;
			if (!ienumerable_0.Any<T>())
			{
				result = default(T);
			}
			else
			{
				Class38<T, U> seed = ienumerable_0.Select(new Func<T, Class38<T, U>>(@class.method_0)).FirstOrDefault<Class38<T, U>>();
				result = ienumerable_0.Select(new Func<T, Class38<T, U>>(@class.method_1)).Aggregate(seed, new Func<Class38<T, U>, Class38<T, U>, Class38<T, U>>(Class119.smethod_4<T, U>)).Object;
			}
			return result;
		}
		public static T smethod_1<T, U>(this IEnumerable<T> ienumerable_0, Func<T, U> func_0) where T : class where U : IComparable
		{
			Class119.Class120<T, U> @class = new Class119.Class120<T, U>();
			@class.func_0 = func_0;
			T result;
			if (!ienumerable_0.Any<T>())
			{
				result = default(T);
			}
			else
			{
				Class38<T, U> seed = ienumerable_0.Select(new Func<T, Class38<T, U>>(@class.method_0)).FirstOrDefault<Class38<T, U>>();
				result = ienumerable_0.Select(new Func<T, Class38<T, U>>(@class.method_1)).Aggregate(seed, new Func<Class38<T, U>, Class38<T, U>, Class38<T, U>>(Class119.smethod_5<T, U>)).Object;
			}
			return result;
		}
		public static IEnumerable<T> smethod_2<T>(this IEnumerable<T> ienumerable_0)
		{
			if (ienumerable_0 == null)
			{
				throw new ArgumentNullException("Shuffle(): source == null");
			}
			return ienumerable_0.smethod_3<T>();
		}
		private static IEnumerable<T> smethod_3<T>(this IEnumerable<T> ienumerable_0)
		{
			Class119.Class118<T> @class = new Class119.Class118<T>(-2);
			@class.ienumerable_1 = ienumerable_0;
			return @class;
		}
		[CompilerGenerated]
		private static Class38<T, U> smethod_4<T, U>(Class38<T, U> class38_0, Class38<T, U> class38_1) where T : class where U : IComparable
		{
			U value = class38_0.Value;
			return (value.CompareTo(class38_1.Value) <= 0) ? class38_0 : class38_1;
		}
		[CompilerGenerated]
		private static Class38<T, U> smethod_5<T, U>(Class38<T, U> class38_0, Class38<T, U> class38_1) where T : class where U : IComparable
		{
			U value = class38_0.Value;
			return (value.CompareTo(class38_1.Value) > 0) ? class38_0 : class38_1;
		}

    // Nested Types
    [CompilerGenerated]
    private sealed class Class118<T> : IEnumerable<T>, IEnumerator<T>, IDisposable
    {
      // Fields
      private T gparam_0;
      public T[] gparam_1;
      public T gparam_2;
      public T[] gparam_3;
      public IEnumerable<T> ienumerable_0;
      public IEnumerable<T> ienumerable_1;
      private int int_0;
      private int int_1;
      public int int_2;
      public Random random_0;

      // Methods
      
      public Class118(int int_3)
      {
        this.int_0 = int_3;
        this.int_1 = Thread.CurrentThread.ManagedThreadId;
      }

      private void method_0()
      {
        this.int_0 = -1;
      }

      private bool MoveNext()
        {
            try
            {
                int length;
                int num3;
                switch (this.int_0)
                {
                    case 0:
                        this.int_0 = -1;
                        this.gparam_1 = this.ienumerable_0.ToArray<T>();
                        this.random_0 = new Random();
                        length = this.gparam_1.Length;
                        goto Label_0095;

                    case 2:
                        goto Label_00B7;

                    default:
                        goto Label_00E4;
                }
            Label_004C:
                num3 = this.random_0.Next(length--);
                if (length != num3)
                {
                    T local = this.gparam_1[num3];
                    this.gparam_1[num3] = this.gparam_1[length];
                    this.gparam_1[length] = local;
                }
            Label_0095:
                if (length > 1)
                {
                    goto Label_004C;
                }
                this.int_0 = 1;
                this.gparam_3 = this.gparam_1;
                this.int_2 = 0;
                goto Label_00CC;
            Label_00B7:
                this.int_0 = 1;
                this.int_2++;
            Label_00CC:
                if (this.int_2 < this.gparam_3.Length)
                {
                    goto Label_00E9;
                }
                this.method_0();
            Label_00E4:
                return false;
            Label_00E9:
                this.gparam_2 = this.gparam_3[this.int_2];
                this.gparam_0 = this.gparam_2;
                this.int_0 = 2;
                return true;
            }
            finally
            {
              ((System.IDisposable)this).Dispose();
              
                
            }
        }

      
      IEnumerator<T> IEnumerable<T>.GetEnumerator()
      {
        Class119.Class118<T> class2;
        if ((Thread.CurrentThread.ManagedThreadId == this.int_1) && (this.int_0 == -2))
        {
          this.int_0 = 0;
          class2 = (Class119.Class118<T>)this;
        }
        else
        {
          class2 = new Class119.Class118<T>(0);
        }
        class2.ienumerable_0 = this.ienumerable_1;
        return class2;
      }

      
      /*IEnumerator IEnumerable.GetEnumerator()
      {
        return ((System.Collections.Generic.IEnumerable<T>)this).GetEnumerator();
      }*/

     
      void Reset()
      {
        throw new NotSupportedException();
      }

      void IDisposable.Dispose()
      {
        switch (this.int_0)
        {
          case 1:
          case 2:
            this.method_0();
            break;
        }
      }

      // Properties
      T IEnumerator<T>.Current
      {
       
        get
        {
          return this.gparam_0;
        }
      }



      System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
      {
        return ((System.Collections.Generic.IEnumerable<T>)this).GetEnumerator();
      }

      object System.Collections.IEnumerator.Current
      {
        get { return this.gparam_0; }
      }

      bool System.Collections.IEnumerator.MoveNext()
      {
        try
        {
          int length;
          int num3;
          switch (this.int_0)
          {
            case 0:
              this.int_0 = -1;
              this.gparam_1 = this.ienumerable_0.ToArray<T>();
              this.random_0 = new Random();
              length = this.gparam_1.Length;
              goto Label_0095;

            case 2:
              goto Label_00B7;

            default:
              goto Label_00E4;
          }
        Label_004C:
          num3 = this.random_0.Next(length--);
          if (length != num3)
          {
            T local = this.gparam_1[num3];
            this.gparam_1[num3] = this.gparam_1[length];
            this.gparam_1[length] = local;
          }
        Label_0095:
          if (length > 1)
          {
            goto Label_004C;
          }
          this.int_0 = 1;
          this.gparam_3 = this.gparam_1;
          this.int_2 = 0;
          goto Label_00CC;
        Label_00B7:
          this.int_0 = 1;
          this.int_2++;
        Label_00CC:
          if (this.int_2 < this.gparam_3.Length)
          {
            goto Label_00E9;
          }
          this.method_0();
        Label_00E4:
          return false;
        Label_00E9:
          this.gparam_2 = this.gparam_3[this.int_2];
          this.gparam_0 = this.gparam_2;
          this.int_0 = 2;
          return true;
        }
        finally
        {
          ((System.IDisposable)this).Dispose();


        }
      }

      void System.Collections.IEnumerator.Reset()
      {
        throw new NotImplementedException();
      }
    }


	}
}
