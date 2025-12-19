namespace FacadePattern.homework;

public class AudioMixer
{
    public void Initialize()
    {
        Console.WriteLine("AudioMixer: 사운드 시스템 초기화 시작");
    }

    public void PlaySound(string soundFile)
    {
        Console.WriteLine($"AudioMixer: {soundFile} 초기화");
    }
}