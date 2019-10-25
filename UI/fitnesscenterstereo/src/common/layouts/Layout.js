import React from 'react';
import Header from '../components/Header';
import Footer from '../components/Footer';
import SideBar from '../components/SideBar';

export default (props) => {
    return (
        <React.Fragment>
            <Header />
            <SideBar />
            {props.children}
            <Footer />
        </React.Fragment>
    )
}
