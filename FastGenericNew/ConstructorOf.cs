﻿using System;
using System.Reflection;

namespace FastGenericNew
{
    public static class ConstructorOf<T>
    {
        public static readonly ConstructorInfo value =
            typeof(T).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Type.EmptyTypes, null);
    }

    public static class ConstructorOf<T, TParameter>
    {
        public static readonly ConstructorInfo value =
            typeof(T).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[]
            {
                typeof(TParameter)
            }, null);
    }

    public static class ConstructorOf<T, TParameter, TParameter2>
    {
        public static readonly ConstructorInfo value =
            typeof(T).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[]
            {
                typeof(TParameter),
                typeof(TParameter2)
            }, null);
    }

    public static class ConstructorOf<T, TParameter, TParameter2, TParameter3>
    {
        public static readonly ConstructorInfo value =
            typeof(T).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[]
            {
                typeof(TParameter),
                typeof(TParameter2),
                typeof(TParameter3),
            }, null);
    }

    public static class ConstructorOf<T, TParameter, TParameter2, TParameter3, TParameter4>
    {
        public static readonly ConstructorInfo value =
            typeof(T).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[]
            {
                typeof(TParameter),
                typeof(TParameter2),
                typeof(TParameter3),
                typeof(TParameter3),
            }, null);
    }

    public static class ConstructorOf<T, TParameter, TParameter2, TParameter3, TParameter4, TParameter5>
    {
        public static readonly ConstructorInfo value =
            typeof(T).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[]
            {
                typeof(TParameter),
                typeof(TParameter2),
                typeof(TParameter3),
                typeof(TParameter4),
                typeof(TParameter5),
            }, null);
    }

    public static class ConstructorOf<T, TParameter, TParameter2, TParameter3, TParameter4, TParameter5, TParameter6>
    {
        public static readonly ConstructorInfo value =
            typeof(T).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[]
            {
                typeof(TParameter),
                typeof(TParameter2),
                typeof(TParameter3),
                typeof(TParameter4),
                typeof(TParameter5),
                typeof(TParameter6),
            }, null);
    }

    public static class ConstructorOf<T, TParameter, TParameter2, TParameter3, TParameter4, TParameter5, TParameter6, TParameter7>
    {
        public static readonly ConstructorInfo value =
            typeof(T).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[]
            {
                typeof(TParameter),
                typeof(TParameter2),
                typeof(TParameter3),
                typeof(TParameter4),
                typeof(TParameter5),
                typeof(TParameter6),
                typeof(TParameter7),
            }, null);
    }

    public static class ConstructorOf<T, TParameter, TParameter2, TParameter3, TParameter4, TParameter5, TParameter6, TParameter7, TParameter8>
    {
        public static readonly ConstructorInfo value =
            typeof(T).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[]
            {
                typeof(TParameter),
                typeof(TParameter2),
                typeof(TParameter3),
                typeof(TParameter4),
                typeof(TParameter5),
                typeof(TParameter6),
                typeof(TParameter7),
                typeof(TParameter8),
            }, null);
    }

    public static class ConstructorOf<T, TParameter, TParameter2, TParameter3, TParameter4, TParameter5, TParameter6, TParameter7, TParameter8, TParameter9>
    {
        public static readonly ConstructorInfo value =
            typeof(T).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[]
            {
                typeof(TParameter),
                typeof(TParameter2),
                typeof(TParameter3),
                typeof(TParameter4),
                typeof(TParameter5),
                typeof(TParameter6),
                typeof(TParameter7),
                typeof(TParameter8),
                typeof(TParameter9),
            }, null);
    }
}
