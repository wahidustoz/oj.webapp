
using oj.webapp.Dto;

namespace oj.webapp.Services;

public interface IProblemService
{
    Task<List<Problem>> GetProblemsAsync(int limit = 10, int page = 1, string difficulty = "", string keyword = "");
}