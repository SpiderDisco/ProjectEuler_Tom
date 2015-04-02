using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class AlternativeVote
    {
        public static void Solve()
        {
            List<Voter> voters = new List<Voter>
		    {
                new Voter("a","c","b"),
			    new Voter("b","a","c"),

			    new Voter("c","b","a"),
			    new Voter("a","c","b"),

			    new Voter("b","a","c")
		    };

            ElectionManager election = new ElectionManager();
            election.AddCandidate("a");
            election.AddCandidate("b");
            election.AddCandidate("c");

            foreach (Candidate c in election.Candidates.Where(t => t.IsActive == true))
            {
                c.votes = voters.Count(v => v.votes[0] == c.id);
            }
            
            int i = 0;
            while (election.Candidates.Count(t => t.IsActive == true) > 1)
            {
                Tuple<string, int> min = new Tuple<string, int>(null, int.MaxValue);
                foreach (Candidate c in election.Candidates.Where(t => t.IsActive == true))
                {
                    if (c.votes < min.Item2)
                    {
                        min = new Tuple<string, int>(c.id, c.votes);
                    }
                }
                Candidate removedCandidate = election.Candidates.Where(c => c.id == min.Item1).FirstOrDefault();
                removedCandidate.IsActive = false;
                foreach(Voter vote in voters.Where(v=>v.votes[i]==removedCandidate.id))
                {
                    if(election.IsActive(vote.votes[i + 1]))
                        election.CastVote(vote.votes[i + 1]);
                }
                i++;
            }
            foreach (Candidate c in election.Candidates)
            {
                Console.WriteLine(c.id + ": " + c.votes);
            }
            Console.WriteLine("Done");
            Console.ReadKey();
        }
	
    }
    public class ElectionManager
    {
        public List<Candidate> Candidates = new List<Candidate>();
        public int GetCount(string id)
        {
            return Candidates.Where(c => c.id == id).FirstOrDefault().votes;
        }
        public bool IsActive(string id)
        {
            return Candidates.Where(c => c.id == id).FirstOrDefault().IsActive;
        }
        public void Eliminate(string id)
        {
            Candidates.Where(c => c.id == id).FirstOrDefault().IsActive = false;
        }
        public void CastVote(string id)
        {
            Candidates.Where(c => c.id == id).FirstOrDefault().votes++;
        }
        public void AddCandidate(string id)
        {
            Candidates.Add(new Candidate(id));
        }
    }
    public class Candidate
    {
        public Candidate(string id)
        {
            this.id = id;
            votes = 0;
            IsActive = true;
        }

        public int votes;
        public string id;
        public bool IsActive;
    }
    public class Voter
    {
        public Voter(string v1, string v2, string v3)
        {
            votes = new string[] { v1, v2, v3 };
        }
        public string[] votes;
    }
}
