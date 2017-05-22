using Newtonsoft.Json;

namespace SharedLibrary
{
    public static class Comparer
    {
        // HELPER CLASS TO COMPARE TWO OBJECTS BY CONVERTING TO JSON
        public static bool JsonCompare(object actual, object another)
        {
            if (ReferenceEquals(actual, another)) return true;
            if ((actual == null) || (another == null)) return false;
            if (actual.GetType() != another.GetType()) return false;

            var objJson = JsonConvert.SerializeObject(actual);
            var anotherJson = JsonConvert.SerializeObject(another);

            return objJson == anotherJson;
        }


    }
}
