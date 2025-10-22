class Hall {
  constructor(hall_id, hall_name) {
    this.hall_id = hall_id;
    this.hall_name = hall_name;
  }
}

class Movie {
  constructor(movie_id, title, budget, description, release_date, box_office, duration, tagline, average_rating) {
    this.movie_id = movie_id;
    this.title = title;
    this.budget = budget;
    this.description = description;
    this.release_date = release_date;
    this.box_office = box_office;
    this.duration = duration;
    this.tagline = tagline;
    this.average_rating = average_rating;
  }
}

class Genre {
  constructor(genre_id, genre_name) {
    this.genre_id = genre_id;
    this.genre_name = genre_name;
  }
}

class MovieGenre {
  constructor(movie_id, genre_id) {
    this.movie_id = movie_id;
    this.genre_id = genre_id;
  }
}

class Showing {
  constructor(showing_id, show_time, price) {
    this.showing_id = showing_id;
    this.show_time = show_time;
    this.price = price;
  }
}

class Schedule {
  constructor(schedule_id, hall_id, showing_id, movie_id) {
    this.schedule_id = schedule_id;
    this.hall_id = hall_id;
    this.showing_id = showing_id;
    this.movie_id = movie_id;
  }
}

class Client {
  constructor(client_id, last_name, first_name) {
    this.client_id = client_id;
    this.last_name = last_name;
    this.first_name = first_name;
  }
}

class Ticket {
  constructor(ticket_id, show_date, schedule_id, client_id, seat) {
    this.ticket_id = ticket_id;
    this.show_date = show_date;
    this.schedule_id = schedule_id;
    this.client_id = client_id;
    this.seat = seat;
  }
}
