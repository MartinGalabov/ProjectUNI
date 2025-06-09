using FinalWorkingProject.Models;
using System.Collections.Generic;

namespace FinalWorkingProject.Services
{
    public static class InMemoryKafkaQueue
    {

        public static Queue<Movie> Queue { get; } = new Queue<Movie>();
    }
}