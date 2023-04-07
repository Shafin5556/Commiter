const Header = ({ logo }) => {
  return (
    <div className="dizme_tm_header">
      <div className="container">
        <div className="inner">
          <div className="logo">
            <a href="#">
            </a>
          </div>
          <div className="menu">
            <ul className="anchor_nav">
              <li className="current">
                <a href="#home">Home</a>
              </li>
              <li>
                <a href="#BIO">BIO</a>
              </li>
              <li>
                <a href="#RESEARCH">RESEARCH</a>
              </li>
              <li>
                <a href="#TEACHING">TEACHING</a>
              </li>
              <li>
                <a href="#PUBLICATIONS">PUBLICATIONS</a>
              </li>
              <li>
                <a href="#CONTACT">Contact</a>
              </li>
            </ul>
          </div>
        </div>
      </div>
    </div>
  );
};
export default Header;
