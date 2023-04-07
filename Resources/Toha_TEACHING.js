import Counter from "./Counter";
const TEACHING = ({ dark }) => {
  return (
    <div className="dizme_tm_section" id="TEACHING">
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
                <span>{`All Publications`}</span>
              </div>
              <div className="text wow fadeInUp" data-wow-duration="1s">
              <li>
                  {`Evaluation of Peer Instruction for Cybersecurity Education`}
                </li>
                <li>
                  {`BDSI: A Validated Concept Inventory for Basic Data Structures`}
                </li>
                <li>
                  {`Developing Course-Level Learning Goals for Basic Data Structures in CS2`}
                </li>
                <li>
                  {`Integrating Social Justice Topics into CS1`}
                </li>
                <li>
                  {`A multi-institutional study of peer instruction in introductory computing`}
                </li>
                <li>
                  {`Computer science concept inventories: past and future Computer Science Education`}
                </li>
                <li>
                  {`Active Learning in Lecture with Peer Instruction`}
                </li>
                <li>
                  {`Adapting to Pervasive Computing, and Making Great Pedagogy Pervasive`}
                </li>
                <li>
                  {`Can peer instruction be effective in upper-division computer science courses`}
                </li>
                <li>
                  {`On the User–Scheduler Dialogue: Studies of User-Provided Runtime Estimates and Utility Functions `}
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
export default TEACHING;
