using FinalWorkingProject.Models;

namespace FinalWorkingProject.Services
{
    public class KafkaProducer
    {
        public void Publish(Movie movie)
        {

            InMemoryKafkaQueue.Queue.Enqueue(movie);
            Console.WriteLine($"[KafkaProducer] Published: {movie.Title}");
        }
    }
}