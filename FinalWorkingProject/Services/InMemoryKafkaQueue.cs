using KafkaFinalWorkingProject.Models;
using System.Collections.Generic;

namespace KafkaFinalWorkingProject.Services
{
    public static class InMemoryKafkaQueue
    {

        public static Queue<Movie> Queue { get; } = new Queue<Movie>();
    }
}