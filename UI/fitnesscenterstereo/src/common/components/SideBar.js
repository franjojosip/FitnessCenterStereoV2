import SideNav from 'react-simple-sidenav';
import React from 'react';
import { inject, observer } from 'mobx-react';



class SideBar extends React.Component {

    constructor(props) {
        super(props);
        this.state = { showNav: false };
        this.handleClick = this.handleClick.bind(this);
    }

    handleClick(e) {
        const { rootStore } = this.props;
        rootStore.routerStore.goTo(e);
    };

    render() {
        return (
            <div>
                <button onClick={() => this.setState({ showNav: true })}>Pages</button>
                <SideNav
                    showNav={this.state.showNav}
                    onHideNav={() => this.setState({ showNav: false })}
                    title={<div> </div>}
                    titleStyle={{ backgroundColor: '#FFFFFF' }}
                    items={[
                        <div className="btn-group-vertical" role="group" >
                            <button type="button" className="btn btn-success btn-lg btn-block" onClick={() => this.handleClick("bodyparttype")}>BodyPartType</button>
                            <button type="button" className="btn btn-success btn-lg btn-block" onClick={() => this.handleClick("complexityleveltype")}>ComplexityLevelType</button>
                            <button type="button" className="btn btn-success btn-lg btn-block" onClick={() => this.handleClick("diettype")}>DietType</button>
                            <button type="button" className="btn btn-success btn-lg btn-block" onClick={() => this.handleClick("equipment")}>Equipment</button>
                            <button type="button" className="btn btn-success btn-lg btn-block" onClick={() => this.handleClick("exercise")}>Exercises</button>
                            <button type="button" className="btn btn-success btn-lg btn-block" onClick={() => this.handleClick("membership")}>Membership</button>
                            <button type="button" className="btn btn-success btn-lg btn-block" onClick={() => this.handleClick("plan")}>Plan</button>
                            <button type="button" className="btn btn-success btn-lg btn-block" onClick={() => this.handleClick("schedule")}>Schedule</button>
                            <button type="button" className="btn btn-success btn-lg btn-block" onClick={() => this.handleClick("step")}>Step</button>
                            <button type="button" className="btn btn-success btn-lg btn-block" onClick={() => this.handleClick("trainer")}>Trainer</button>
                        </div>
                    
                    ]} />
            </div>
        );
    }
}

export default inject('rootStore')(observer(SideBar));
