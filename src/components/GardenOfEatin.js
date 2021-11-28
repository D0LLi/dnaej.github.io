import React from 'react';
import { makeStyles } from '@material-ui/core/styles';
import { Card, CardContent, CardActionArea, CardMedia, Typography, Grid, Container } from '@material-ui/core/';

const useStyles = makeStyles((theme) => ({
    root: {
        display: 'flex',
        backgroundColor: theme.palette.primary.light,
    },
    card: {
        maxWidth: 250,
        margin: 0,
    },
    media: {
        height: 160,
    },
}));


export default function GardenOfEatin(props) {
    const classes = useStyles();

    if (props.data) {
        var goeProjects = props.data.projects.map(function (projects) {
            var projectImage = 'images/goe/' + projects.image;

            return (
                <div key={projects.title} className="columns portfolio-item">
                <Card className={classes.card}>
                    <CardActionArea href={projects.url}>
                        <CardMedia className={classes.media} image={projectImage} title={projects.title} />
                        <CardContent>
                            <Typography gutterBottom variant="h5" component="h2">{projects.title}</Typography>
                            <Typography variant="body2" gutterBottom>{projects.category}</Typography>
                        </CardContent>
                    </CardActionArea>
                </Card>
                </div>
            )
        })
    }

        

    return (
        <section className={classes.root} id="goe">
            <Container className="row">
            <h1>WIP Designs</h1>
            <div id="portfolio-wrapper" className="bgrid-quarters s-bgrid-thirds cf">
                        {goeProjects}
                    </div>
            </Container>   
    </section>
    );
}