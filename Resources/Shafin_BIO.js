import Counter from "./Counter";
const BIO = ({ dark }) => {
  return (
    <div className="dizme_tm_section" id="BIO">
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
                <span>{`BIO`}</span>
              </div>
              <div className="text wow fadeInUp" data-wow-duration="1s">
                <p>
                  {`Cynthia Lee is a Senior Lecturer in the Computer Science Department at Stanford. She specializes in team-based and question-based course design, and founded peerinstruction4cs.org to support educators in flipping their computer science classrooms using peer instruction. Her teaching awards include the Lloyd W. Dinkelspiel Award for exceptional contributions to undergraduate education at Stanford, a "Top 10 Papers of All Time" award at the 50th anniversary of the ACM SIGCSE technical symposium, and the Stanford Society of Women Engineers' Professor of the Year. She has a PhD in high-performance computing from UC San Diego. Her industry work experience includes NASA Ames and startups.`}
                </p>
              </div>
              <div className="title wow fadeInUp" data-wow-duration="1s">
                <span>{`Academic Appointments`}</span>
              </div>
              <div className="text wow fadeInUp" data-wow-duration="1s">
              <li>
                  {`Senior Lecturer, Computer Science`}
                  </li>
              </div>
              <div className="title wow fadeInUp" data-wow-duration="1s">
                <span>{`Honors & Awards`}</span>
              </div>
              <div className="text wow fadeInUp" data-wow-duration="1s">
              <li>
                  {`Teaching Honor Roll, Stanford Tau Beta Pi (2022)`}
                </li>
                <li>
                  {`Lloyd W. Dinkelspiel Award, Stanford University (2019)`}
                </li>
                <li>
                  {`Top 10 Papers of All Time (#4), ACM SIGCSE (2019)`}
                </li>
                <li>
                  {`Best Paper Award, ACM SIGCSE (2016)`}
                </li>
                <li>
                  {`Professor of the Year, Stanford Society of Women Engineers (2015)`}
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
            </div>
          </div>
        </div>
        <div className="brush_1 wow fadeInLeft" data-wow-duration="1s">
          <img src="img/brushes/about/1.png" alt="image" />
        </div>
        <div className="brush_2 wow fadeInRight" data-wow-duration="1s">
          <img src="img/brushes/about/2.png" alt="image" />
        </div>
      </div>
    </div>
  );
};
export default BIO;
