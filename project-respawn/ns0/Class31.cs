using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Diagnostics;
using System.Threading;
namespace ns0
{
	internal static class Class31
	{

   private sealed class Class32<T> : IEnumerable<T>, IEnumerator<T>, IDisposable
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
     [DebuggerHidden]
     public Class32(int int_3)
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
            int num2;
            switch (this.int_0)
            {
                case 0:
                    this.int_0 = -1;
                    this.gparam_1 = this.ienumerable_0.ToArray<T>();
                    this.random_0 = new Random();
                    length = this.gparam_1.Length;
                    goto Label_0095;

                case 2:
                    goto Label_00B5;

                default:
                    goto Label_00E0;
            }
        Label_004E:
            num2 = this.random_0.Next(length--);
            if (length != num2)
            {
                T local = this.gparam_1[num2];
                this.gparam_1[num2] = this.gparam_1[length];
                this.gparam_1[length] = local;
            }
        Label_0095:
            if (length > 1)
            {
                goto Label_004E;
            }
            this.int_0 = 1;
            this.gparam_3 = this.gparam_1;
            this.int_2 = 0;
            goto Label_00CA;
        Label_00B5:
            this.int_0 = 1;
            this.int_2++;
        Label_00CA:
            if (this.int_2 < this.gparam_3.Length)
            {
                goto Label_00E4;
            }
            this.method_0();
        Label_00E0:
            return false;
        Label_00E4:
            this.gparam_2 = this.gparam_3[this.int_2];
            this.gparam_0 = this.gparam_2;
            this.int_0 = 2;
            return true;
        }
        finally
        {
           ((IDisposable)this).Dispose();
        }
    }

     [DebuggerHidden]
     IEnumerator<T> IEnumerable<T>.GetEnumerator()
     {
       Class31.Class32<T> class2;
       if ((Thread.CurrentThread.ManagedThreadId == this.int_1) && (this.int_0 == -2))
       {
         this.int_0 = 0;
         class2 = (Class31.Class32<T>)this;
       }
       else
       {
         class2 = new Class31.Class32<T>(0);
       }
       class2.ienumerable_0 = this.ienumerable_1;
       return class2;
     }


     [DebuggerHidden]
     IEnumerable<T> GetEnumerable()
     {
       return ((System.Collections.Generic.IEnumerable<T>)this);
     }


     void IDisposable.Dispose()
     {
       switch (this.int_0)
       {
         case 1:
         case 2:
           this.method_0();
           return;
       }
     }

     // Properties
     T IEnumerator<T>.Current
     {
       [DebuggerHidden]
       get
       {
         return this.gparam_0;
       }
     }

    /* object IEnumerator<T>.Current
     {
       [DebuggerHidden]
       get
       {
         return this.gparam_0;
       }
     }*/






     System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
     {
       throw new NotImplementedException();
     }

     object System.Collections.IEnumerator.Current
     {
       get { throw new NotImplementedException(); }
     }

     bool System.Collections.IEnumerator.MoveNext()
     {
       throw new NotImplementedException();
     }

     void System.Collections.IEnumerator.Reset()
     {
       throw new NotImplementedException();
     }
   }

		[CompilerGenerated]
		private sealed class Class34<T, U> where T : class where U : IComparable
		{
			public Func<T, U> func_0;
			public Class21<T, U> method_0(T gparam_0)
			{
				return new Class21<T, U>(gparam_0, this.func_0(gparam_0));
			}
			public Class21<T, U> method_1(T gparam_0)
			{
				return new Class21<T, U>(gparam_0, this.func_0(gparam_0));
			}
		}
		[CompilerGenerated]
		private sealed class Class33<T, U> where T : class where U : IComparable
		{
			public Func<T, U> func_0;
			public Class21<T, U> method_0(T gparam_0)
			{
				return new Class21<T, U>(gparam_0, this.func_0(gparam_0));
			}
			public Class21<T, U> method_1(T gparam_0)
			{
				return new Class21<T, U>(gparam_0, this.func_0(gparam_0));
			}
		}
		public static T smethod_0<T, U>(this IEnumerable<T> ienumerable_0, Func<T, U> func_0) where T : class where U : IComparable
		{
			Class31.Class34<T, U> @class = new Class31.Class34<T, U>();
			@class.func_0 = func_0;
			if (!ienumerable_0.Any<T>())
			{
				return default(T);
			}
			Class21<T, U> seed = ienumerable_0.Select(new Func<T, Class21<T, U>>(@class.method_0)).FirstOrDefault<Class21<T, U>>();
			return ienumerable_0.Select(new Func<T, Class21<T, U>>(@class.method_1)).Aggregate(seed, new Func<Class21<T, U>, Class21<T, U>, Class21<T, U>>(Class31.smethod_4<T, U>)).Object;
		}
		public static T smethod_1<T, U>(this IEnumerable<T> ienumerable_0, Func<T, U> func_0) where T : class where U : IComparable
		{
			Class31.Class33<T, U> @class = new Class31.Class33<T, U>();
			@class.func_0 = func_0;
			if (!ienumerable_0.Any<T>())
			{
				return default(T);
			}
			Class21<T, U> seed = ienumerable_0.Select(new Func<T, Class21<T, U>>(@class.method_0)).FirstOrDefault<Class21<T, U>>();
			return ienumerable_0.Select(new Func<T, Class21<T, U>>(@class.method_1)).Aggregate(seed, new Func<Class21<T, U>, Class21<T, U>, Class21<T, U>>(Class31.smethod_5<T, U>)).Object;
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
			Class31.Class32<T> @class = new Class31.Class32<T>(-2);
			@class.ienumerable_1 = ienumerable_0;
			return @class;
		}
		[CompilerGenerated]
		private static Class21<T, U> smethod_4<T, U>(Class21<T, U> class21_0, Class21<T, U> class21_1) where T : class where U : IComparable
		{
			U value = class21_0.Value;
			if (value.CompareTo(class21_1.Value) > 0)
			{
				return class21_1;
			}
			return class21_0;
		}
		[CompilerGenerated]
		private static Class21<T, U> smethod_5<T, U>(Class21<T, U> class21_0, Class21<T, U> class21_1) where T : class where U : IComparable
		{
			U value = class21_0.Value;
			if (value.CompareTo(class21_1.Value) <= 0)
			{
				return class21_1;
			}
			return class21_0;
		}

    
   
	}
}
