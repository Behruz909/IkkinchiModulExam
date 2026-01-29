namespace ConsoleApp1.Services;

public interface IMusicService
{
 public List<MusicDto> GetAllMusicByAuthorName(string name);

   public List<MusicDto> GetAllMusicAboveSize(double minSize);

   public List<MusicDto> GetTopMostLikedMusic(int count);

   public List<MusicDto> GetMusicWithLikesInRange(int minlikes, int maxlikes);

   public List<MusicDto> GetTotalMusicSizeByAuthor(string authorname);


}
