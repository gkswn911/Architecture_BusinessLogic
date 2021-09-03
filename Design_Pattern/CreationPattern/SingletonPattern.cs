public class Singleton
{
    // static으로 객체를 1개 더 생성.
    private static Singleton staticSigleton;

    // static 함수로 정적 객체를 반환.
    public static Singleton Instance()
    {
        // 생성된 객체가 null 이 되기전까지 static 객체 사용.
        // 객체가 null 이 되면, 가비지 컬렉터에 의해 힙 영역에서 지워진다.
        if(staticSingleton == null)
        {
            staticSingleton = new Singleton();
        }
        return staticSingleton;
    }

    static void Main(string[] args)
    {
        var objectA = Singleton.Instance();
        var objectB = Singleton.Instance();
        var objectC = Singleton.Instance();
        // 하나의 객체에만 지속적으로 접근
    }
}
