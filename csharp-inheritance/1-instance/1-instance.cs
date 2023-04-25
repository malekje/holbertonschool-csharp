using System;

class Obj {
    public static bool IsInstanceOfArray(object obj) {
        return (typeof(Array).IsInstanceOfType(obj));
    }
}
