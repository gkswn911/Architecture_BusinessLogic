/***
 빌더 패턴의 경우 기존 생성자를 통해서 객체를 생성하는 방식이 아닌
 , 객체를 생성하는 클래스를 만들어 해당 클래스에서 인스턴스를 생성하므로 가독성과 유지보수가 쉽도록 고안된 패턴이다.
 Builder를 통해 객체를 생성할 수 있어, 파라미터의 값이 많은 경우에 가독성과 유지보수가 용이한 생성 패턴이다.
***/


// 점수를 저장하는 Class
public class StudentScore
{
    public int Kor;
    public int Mat;
    public int Eng;

    public StudentScore(int kor, int mat, int eng)
    {
        this.Kor = kor;
        this.Mat = mat;
        this.Eng = eng;
    }
}

// Builder Class 생성
public class ScoreBuilder
{
    private StudentScore studentScore;

    ScoreBuilder()
    {
        studentScore = new StudentScore(0, 0, 0);
    }

    public ScoreBuilder SetKor(int value)
    {
        studentScore.Kor = value;
        return this;
    }
    public ScoreBuilder SetMat(int value)
    {
        studentScore.Mat = value;
        return this;
    }
    public ScoreBuilder SetEng(int value)
    {
        studentScore.Eng = value;
        return this;
    }
}

// Builder 객체 인스턴스 생성
public class builderPattern
{
    static void Main(string[] args)
    {
        ScoreBuilder scoreBuilder = new ScoreBuilder();
        scoreBuilder.SetKor(90).SetMat(70).SetKor(60);
    }
}
