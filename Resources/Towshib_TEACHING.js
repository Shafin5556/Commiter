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
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
};
export default TEACHING;
