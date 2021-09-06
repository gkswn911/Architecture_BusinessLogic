/***
Clone을 이용해 객체를 생성하는 방법. 
파생 클래스에서 객체를 생성하는 코드가 별도로 만들어지지 않는다.
기존에 생성된 객체를 이용해 해당 타입의 객체를 생성한다.
***/

public abstract class ProtoType
{
    // 생성되는 파생 클래스에서 재정의 한다.
    public abstract ProtoType Clone();
}

// 파생 클래스 1
public class ConcreteProtoType1 : ProtoType
{
    public override ProtoType Clone()
    {
        return (ConcreteProtoType1)this.MemberwiseClone();
    }
}

// 파생 클래스 2
public class ConcreteProtoType2 : ProtoType
{
    public override ProtoType Clone()
    {
        return (ConcreteProtoType2)this.MemberwiseClone();
    }
}

public class ProtoTypeFactory
{
    private static List<ProtoType> protoTypes = new List<ProtoType>();

    public ProtoTypeFactory()
    {
        protoTypes.Add(new ConcreteProtoType1());
        protoTypes.Add(new ConcreteProtoType2());
    }

    public ProtoType Create<T>() where T : ProtoType
    {
        return protoTypes.Find(pt => pt is T).Clone();
    }
}

public class prototypePattern
{
    static void Main(string [] args)
    {
        ProtoTypeFactory protoTypeFactory = new ProtoTypeFactory();
        var concreteProtoType1 = protoTypeFactory.Create<ConcreteProtoType1>();
        var concreteProtoType2 = protoTypeFactory.Create<ConcreteProtoType2>();
    }
}