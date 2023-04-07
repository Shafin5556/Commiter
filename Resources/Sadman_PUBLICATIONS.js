import Counter from "./Counter";
const PUBLICATIONS = ({ dark }) => {
  return (
    <div className="dizme_tm_section" id="PUBLICATIONS">
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
                <span>{`2022-23 Courses`}</span>
              </div>
              <div className="text wow fadeInUp" data-wow-duration="1s">
              <li>
                  {`Mathematical Foundations of Computing.`}
                </li>
                <li>
                  {`Problem-solving Lab for CS106B.`}
                </li>
                <li>
                  {`Programming Abstractions.`}
                </li>
                <li>
                  {`Race and Gender in Silicon Valley.`}
                </li>
              </div>
              <div className="title wow fadeInUp" data-wow-duration="1s">
                <span>{`Stanford Advisees`}</span>
              </div>
              <div className="text wow fadeInUp" data-wow-duration="1s">
              <li>
                  {`Master's Program Advisor.`}
                  </li>
                  <li>
                  {`Stephanie Brito, Kasey Luo, Trip Master.`}
                  </li>
              </div>
            </div>
          </div>
        </div>
        <div className="brush_2 wow fadeInRight" data-wow-duration="1s">
          <img src="img/brushes/about/2.png" alt="image" />
        </div>
      </div>
    </div>
  );
};
export default PUBLICATIONS;
