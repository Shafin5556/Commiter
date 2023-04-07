import Counter from "./Counter";
const RESEARCH = ({ dark }) => 
{
  return (
    <div className="dizme_tm_section" id="RESEARCH">
      <div className="dizme_tm_about">
        <div className="container">
          <div className="wrapper">
            <div className="left">
              <div className="image">
                <div className="numbers year">
                </div>
                <div className="numbers project">
                </div>
              </div>
            </div>
            <div className="center">
              <div className="title wow fadeInUp" data-wow-duration="1s">
                <span>{`Current Research and Scholarly Interests`}</span>
              </div>
              <div className="text wow fadeInUp" data-wow-duration="1s">
                <p>
                  {`I have a PhD in Computer Science from the University of California, San Diego, in the area of High-Performance Computing (HPC), specifically market-based scheduling algorithms. My graduate research was done as part of San Diego Supercomputer Center (SDSC)'s Performance Modeling and Characterization Lab (PMaC), where I investigated economic models of scheduling on high performance computing systems. My adviser was Allan Snavely of SDSC.

My dissertation abstract is as follows: Effective management of Grid and HPC resources is essential to maximizing return on the substantial infrastructure investment these resources entail. An important prerequisite to effective resource management is productive interaction between the user and scheduler. My work analyzes several aspects of the user-scheduler relationship and develops solutions to three of the most vexing barriers between the two. First, users' monetary valuation of compute time and schedule turnaround time is examined in terms of a utility function. Second, responsiveness of the scheduler to users' varied valuations is optimized via a genetic algorithm heuristic, creating a controlled market for computation. Finally, the chronic problem of inaccurate user runtime requests, and its implications for scheduler performance, is examined, along with mitigation techniques.

My current research projects are in the area of Computer Science Education, with an emphasis on assessment and the use of Peer Instruction pedagogy in lecture. With colleagues Mark Guzdial, Leo Porter, and Beth Simon, I run the New CS Faculty Teaching Workshop, an annual "bootcamp" on how to teach effectively that draws attendees from dozens of the top CS programs in the country. The short-term goal is to give newly-hired faculty entering their first year of teaching the skills they need to succeed for themselves and their students. The long-term goal is to transform undergraduate education in CS by seeding our best rising stars with best practices so they can create communities of practice as their institutions and mentor their students in active learning strategies, creating a culture where these are the new norm.`}
                </p>
              </div>
              <div className="title wow fadeInUp" data-wow-duration="1s">
                <span>{`Projects`}</span>
              </div>
              <div className="text wow fadeInUp" data-wow-duration="1s">
              <li>
                  {`New Faculty Workshop`}
                </li>
                <li>
                  {`Instructor tips for creating inclusive CS classrooms, Stanford University`}
                  </li>
              </div>
              <div className="title wow fadeInUp" data-wow-duration="1s">
                <span>{`Professional Education`}</span>
              </div>
              <div className="text wow fadeInUp" data-wow-duration="1s">
              <li>
                  {`Ph.D., University of California, San Diego, Computer Science (2009)`}
                  </li>
                  <li>
                  {`B.S., University of California, San Diego, Computer Science (2001)`}
                  </li>
              </div>
              <div
                className="dizme_tm_button wow fadeInUp"
                data-wow-duration="1s"
              >
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
};
export default RESEARCH;
