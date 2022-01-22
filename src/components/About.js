import React from 'react';

export default function About(props) {

    if (props.data) {
        var name = props.data.name;
        var profilepic = 'images/' + props.data.image;
        var bio = props.data.bio;
        var about = props.data.aboutme;
        var street = props.data.address.street;
        var city = props.data.address.city;
        var state = props.data.address.state;
        var phone = props.data.phone;
        var email = props.data.email;
        var resumeDownload = props.data.resumedownload;
    }

    return (
        <section id="about">
            <div className="row">
                <div className="three columns">
                    <img className="profile-pic" src={profilepic} alt="Deneé Profile Picture" />
                </div>
                <div className="nine columns main-col">
                    <h2><a href={about}>About Me</a></h2>

                    <p>{bio}</p>
                    <div className="row">
                        <div className="columns contact-details">
                            <h2>Contact Details</h2>
                            <p className="address">
                                <span>{name}</span><br />
                                <span>{street}<br />
                                    {city} {state}
                                </span><br />
                                <span>{phone}</span><br />
                                <span>{email}</span>
                            </p>
                        </div>
                        <div className="columns download">
                            <p>
                                <a href={resumeDownload} className="button"><i className="fab fa-linkedin"></i>Visit on LinkedIn</a>
                            </p>
                        </div>
                    </div>
                </div>
            </div>
        </section>
    );
}

