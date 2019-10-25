import React from 'react';
import { Navbar, Nav, Form, Button, FormControl } from 'react-bootstrap';
import { inject, observer } from 'mobx-react';

@inject('rootStore')
@observer
class Header extends React.Component {
  handleClick(e) {
    const { rootStore } = this.props;
    rootStore.routerStore.goTo(e);
}
  render() {
    return (
      <Navbar bg="light" expand="lg">
        <Navbar.Toggle aria-controls="basic-navbar-nav" />
        <Navbar.Collapse id="basic-navbar-nav">
          <Nav className="mr-auto">
            <Nav.Link onClick={() => this.handleClick("home")}>Home</Nav.Link>
            <Nav.Link href="#link1">About us</Nav.Link>
            <Nav.Link href="#link2">Login/Register</Nav.Link>

          </Nav>
          <Form inline>
            <FormControl type="text" placeholder="Search" className="mr-sm-2" />
            <Button variant="outline-success">Search</Button>
          </Form>
        </Navbar.Collapse>
      </Navbar>
    );
  }
}

export default Header;
