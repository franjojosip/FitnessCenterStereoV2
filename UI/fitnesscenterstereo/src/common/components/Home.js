import React from 'react';
import './home.css'
import { Card } from 'react-bootstrap';
import picture from '../../images/gym.jpg'
import { inject, observer } from 'mobx-react';
import Header from './Header';
import Footer from './Footer';
import SideBar from './SideBar';

@inject(stores => ({
  rootStore: stores.rootStore
}))
@observer
class Home extends React.Component {
  render() {
    return (
      <div>
        <Header />
        <SideBar/>
        <div className="row" >
          <div className="col">
            <Card className="card card-inline">
              <Card.Img variant="bottom" alt="Trainers image" src={picture} />
              <Card.Body>
                <button type="button " className="btn btn-outline-success btn-lg btn-block">Trainers</button>
              </Card.Body>
            </Card>
          </div>
          <div className="col">
            <Card className="card card-inline">
              <Card.Img variant="bottom" alt="Plans image" src={picture} />
              <Card.Body>
                <button type="button " className="btn btn-outline-success btn-lg btn-block">Plans</button>
              </Card.Body>
            </Card>
          </div>
          <div className="col">
            <Card className="card card-inline">
              <Card.Img variant="bottom" alt="Cards image" src={picture} />
              <Card.Body>
                <button type="button " className="btn btn-outline-success btn-lg btn-block">Cards</button>
              </Card.Body>
            </Card>
          </div>
          <div className="col">
            <Card className="card card-inline">
              <Card.Img variant="bottom" alt="Exercises image" src={picture} />
              <Card.Body>
                <button type="button " className="btn btn-outline-success btn-lg btn-block">Exercises</button>
              </Card.Body>
            </Card>
          </div>
        </div>
        <Footer />
      </div>
    );
  }
}

export default Home;